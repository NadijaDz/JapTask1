import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { IngredientsService } from 'src/app/core/services/ingredients.service';
import { RecipesService } from 'src/app/core/services/recipes.service';
import { NgbModal, NgbModalOptions } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { AddIngredientsComponent } from 'src/app/features/ingredients/add-ingredients/add-ingredients.component';
import { Ingredient } from 'src/app/core/models/ingredient.model';
import { MeasureUnit } from 'src/app/core/models/measure-unit.model';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css'],
})
export class AddRecipeComponent implements OnInit {
  recipeForm: FormGroup;
  categoryId: string;
  ingredients: Ingredient[] = [];
  measureUnits = MeasureUnit;
  enumKeys=[];
  totalCost: any = 0;
  nameofCategory: string;
  closeResult: string;
  modalOptions: NgbModalOptions;
  disabledMeasureUnits: boolean[] = new Array(false,false,false,false,false);
  ingredientEumKeys:any=[];
  
  constructor(
    private route: ActivatedRoute,
    private ingredientsService: IngredientsService,
    private recipesService: RecipesService,
    private router: Router,
    private modalService: NgbModal,
    private toastr: ToastrService
  ) {
    this.enumKeys = Object.keys(this.measureUnits).filter(f => !isNaN(Number(f)));
  }

  ngOnInit() {
    this.categoryId = this.route.snapshot.paramMap.get('id');
    this.nameofCategory = this.route.snapshot.paramMap.get('name');
    this.initializeForm();
    this.getIngredients();
  }

  initializeForm() {
    this.recipeForm = new FormGroup({
      name: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required),
      ingredients: new FormArray([], Validators.required),
    });
  }

  get form() {
    return this.recipeForm.controls;
  }

  onSubmit() {
    if (this.recipeForm.invalid) {
      return;
    }

    this.recipeForm.value.recipeCategory_Id = this.categoryId;
    this.recipesService
      .save(this.recipeForm.value)
      .pipe(first())
      .subscribe(
        (data) => {
          this.toastr.success('Data is successfully saved!', 'Success!');
          this.router.navigate([
            '/recipes/' + this.categoryId + '/' + this.nameofCategory,
          ]);
        },
        (error) => {
          this.toastr.error('Something went wrong', 'Error!');
        }
      );
  }

  getIngredients() {
    this.ingredientsService
      .get()
      .pipe(first())
      .subscribe((response: any) => {
        this.ingredients = response;
      });
  }

  addNewIngredient() {
    (<FormArray>this.recipeForm.get('ingredients')).push(
      new FormGroup({
        ingredient_Id: new FormControl(null, Validators.required),
        measureUnit: new FormControl(null, Validators.required),
        unitQuantity: new FormControl(null, Validators.required),
        costIngredient: new FormControl(0),
        
      })
    );
    this.ingredientEumKeys.push([]);
  }

  // Add New Ingredient Input in the form
  addIngredientInForm() {
    return (<FormArray>this.recipeForm.get('ingredients')).controls;
  }

  deleteIngredient(index: number) {
    this.totalCost -=
      this.recipeForm.get('ingredients')['controls'][index][
        'controls'
      ].costIngredient.value;
    (<FormArray>this.recipeForm.get('ingredients')).removeAt(index);
    this.ingredientEumKeys.removeAt(index);

  }

  totalCostPerIngredient(index) {

    var ingredientId =
      this.recipeForm.get('ingredients')['controls'][index]['controls']
        .ingredient_Id.value;
    var measureUnit =
      this.recipeForm.get('ingredients')['controls'][index]['controls']
        .measureUnit.value;
    var unitQuantity =
      this.recipeForm.get('ingredients')['controls'][index]['controls']
        .unitQuantity.value;

    if (ingredientId != null && measureUnit != null && unitQuantity != null) {
      var ingredient = this.ingredients.find((x) => x.id == ingredientId);
      var measureUnit = MeasureUnit[measureUnit].toString();


       var priceIngredient = 0;
      if (ingredient.measureUnit.toString() == measureUnit || measureUnit == 'kom') 
      {
        priceIngredient = (ingredient.costIngredient * unitQuantity)/1000;
      }
      else{
        priceIngredient=((ingredient.costIngredient/1000)*(unitQuantity))/1000;
      }
    
      this.recipeForm.get('ingredients') ['controls'][index]['controls']['costIngredient'].setValue(priceIngredient);
      this.totalCost = 0;
      for (let i = 0; i < this.recipeForm.get('ingredients')['controls'].length;i++) {
        this.totalCost += (this.recipeForm.get('ingredients')['controls'][i]['controls'].costIngredient.value);
      }
    }
  }


  changeMeasureUnit(index) {

    var ingredientId = (<FormArray>this.recipeForm.get('ingredients')).controls[index]['controls'].ingredient_Id.value;

    var ingredient = this.ingredients.find((x) => x.id == ingredientId);
    var measureUnitFromIngredient = ingredient.measureUnit;

    var measureUnitValueFromIngredient=MeasureUnit[measureUnitFromIngredient].toString();

    //set measure unit base measure unit from ingredient
    this.recipeForm
      .get('ingredients')
      ['controls'][index]['controls']['measureUnit'].setValue(
        measureUnitValueFromIngredient
      );

    //1=kg, 2=gr, 3=L, 4=ml, 5=kom
    switch (measureUnitValueFromIngredient) {
      case '1':
      case '2':
          var valueKgAndGr = Object.keys(this.measureUnits).filter(f => !isNaN(Number(f)) && f=='1' || f=='2');
          this.ingredientEumKeys[index]=valueKgAndGr;
        break;

      case '3':
      case '4':

          var valueLAndMl = Object.keys(this.measureUnits).filter(f => !isNaN(Number(f)) && f=='3' || f=='4');
          this.ingredientEumKeys[index]=valueLAndMl;
        break;

     case '5':
         var valueKom = Object.keys(this.measureUnits).filter(f => !isNaN(Number(f)) && f=='5');
         this.ingredientEumKeys[index]=valueKom;
        break;

      default:
        break;
    }
  }

  open() {
    const modalRef = this.modalService.open(AddIngredientsComponent, {
      scrollable: true,
    });

    modalRef.result.then(
      (result) => {
        this.ingredients.push(result);
      },
      (reason) => {}
    );
  }
}
