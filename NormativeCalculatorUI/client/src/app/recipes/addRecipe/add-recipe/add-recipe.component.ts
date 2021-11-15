import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { IngredientsService } from 'src/app/services/ingredients.service';
import { RecipesService } from 'src/app/services/recipes.service';
import { MeasureUnitService } from 'src/app/services/measure-unit.service';
import { NgbModal, NgbModalOptions } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { AddIngredientsComponent } from 'src/app/ingredients/add-ingredients/add-ingredients.component';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  recipeForm: FormGroup;
  categoryId:any;
  ingredients:any=[];
  measureUnits:any=[];
  allMeasureUnits:any=[];
  totalCost:any=0;
  nameofCategory:string;
  closeResult: string;
  modalOptions:NgbModalOptions;

  constructor(private route: ActivatedRoute, private ingredientsService: IngredientsService,
    private recipesService: RecipesService, private measureUnitService: MeasureUnitService, 
    private router: Router, private modalService: NgbModal, private toastr: ToastrService) { }

  ngOnInit() {
    this.categoryId =this.route.snapshot.paramMap.get('id');
    this.nameofCategory =this.route.snapshot.paramMap.get('name');
    this.initializeForm();
    this.getIngredients();
    this.getMeasureUnit();
  }

  initializeForm(){
    this.recipeForm=new FormGroup({
      name: new FormControl("", Validators.required),
      description: new FormControl("", Validators.required),
      ingredients:new FormArray([], Validators.required)
    })
  }

  get form() {
    return this.recipeForm.controls;
  }

  onSubmit(){

    if (this.recipeForm.invalid) {
     return;
   }

    this.recipeForm.value.recipeCategory_Id=this.categoryId;
    this.recipesService.save(this.recipeForm.value).pipe(first()).subscribe(
      (data)=>{
        this.toastr.success("Data is successfully saved!", "Success!");
        this.router.navigate(["/recipes/" + this.categoryId + '/' + this.nameofCategory]);
      },
      (error) => {
      this.toastr.error("Something went wrong", "Error!");
     }
    )
  }

  getIngredients(){
  
    this.ingredientsService.get().pipe(first()).subscribe(
      (response:any)=>{
       this.ingredients=response;
     
      }
    )
 }

 getMeasureUnit(){
  
  this.measureUnitService.get().pipe(first()).subscribe(
    (response:any)=>{
     this.allMeasureUnits=response;
     this.measureUnits=response;
     this.measureUnits.map(obj=> ({ ...obj, isDisabled: 'false' }))
    }
  )
}

   addNewIngredient(){
    (<FormArray>this.recipeForm.get('ingredients')).push(new FormGroup({
      'ingredient_Id': new FormControl(null,   Validators.required),
      'measureUnit_Id': new FormControl(null,   Validators.required),
      'unitQuantity': new FormControl(null, Validators.required),
      'costIngredient': new FormControl(0)

    }));
  }

   // Add New Ingredient Input in the form
   addIngredientInForm() {
    return (<FormArray>this.recipeForm.get('ingredients')).controls;

  }

    deleteIngredient(index: number){
      
      this.totalCost-=this.recipeForm.get('ingredients')["controls"][index]["controls"].costIngredient.value;  
      (<FormArray>this.recipeForm.get('ingredients')).removeAt(index);
    }
  
    totalCostPerIngredient(index){

      var ingredientId = this.recipeForm.get('ingredients')["controls"][index]["controls"].ingredient_Id.value;
      var measureUnit_Id = this.recipeForm.get('ingredients')["controls"][index]["controls"].measureUnit_Id.value;
      var unitQuantity = this.recipeForm.get('ingredients')["controls"][index]["controls"].unitQuantity.value;

      if(ingredientId != null && measureUnit_Id != null && unitQuantity != null){

        var ingredient=this.ingredients.find(x=> x.id == ingredientId);
        var measureUnit=this.allMeasureUnits.find(x=>x.id == measureUnit_Id);

        var priceIngredient=0;
        if(ingredient.measureUnit_Id==measureUnit_Id || measureUnit.measureUnit == "kom"){
          priceIngredient= ingredient.unitPrice * unitQuantity;
        }
        else{
      
          var measureFromIngredient=this.allMeasureUnits.find(x=>x.id == ingredient.measureUnit_Id);
           if(measureUnit.measureUnit === "gr" && measureFromIngredient.measureUnit==="kg"){
            priceIngredient= ingredient.unitPrice * (unitQuantity/1000);
           }
           if(measureUnit.measureUnit ==="kg" && measureFromIngredient.measureUnit ==="gr"){
            priceIngredient= ingredient.unitPrice * (unitQuantity*1000);
           }
           if(measureUnit.measureUnit === "ml" && measureFromIngredient.measureUnit ==="L"){
            priceIngredient= ingredient.unitPrice * (unitQuantity/1000);
           }
           if(measureUnit.measureUnit === "L" && measureFromIngredient.measureUnit ==="ml"){
            priceIngredient= ingredient.unitPrice * (unitQuantity*1000);
           }
        }
     
        this.recipeForm.get('ingredients')["controls"][index]["controls"]["costIngredient"]
            .setValue(priceIngredient);
        this.totalCost=0;
        for (let i = 0; i < this.recipeForm.get('ingredients')["controls"].length; i++) {
           this.totalCost+=this.recipeForm.get('ingredients')["controls"][i]["controls"].costIngredient.value;  
        }

       
      } 
    }

    changeMeasureUnit(index){

      var ingredientId = (<FormArray>this.recipeForm.get('ingredients')).controls[index]["controls"].ingredient_Id.value;
      
      var ingredient=this.ingredients.find(x=>x.id==ingredientId);
      var measureUnit=this.allMeasureUnits.find(x=>x.id == ingredient.measureUnit_Id);

      //set measure unit base measure unit from ingredient
      this.recipeForm.get('ingredients')["controls"][index]["controls"]["measureUnit_Id"]
            .setValue(measureUnit.id);

      switch (measureUnit.measureUnit) {
        case "L":
          this.measureUnits.forEach(e => {
            if(e.measureUnit === "L" || e.measureUnit === "ml")
            {
              e.isDisabled=false;
            }
            else{
              e.isDisabled=true;
            }
          });
       break;
       case "kg":
        this.measureUnits.forEach(e => {
          if(e.measureUnit === "kg" || e.measureUnit === "gr")
          {
            e.isDisabled=false;
          }
          else{
            e.isDisabled=true;
          }
        });
       break;
       case "kom":
        this.measureUnits.forEach(e => {
          if(e.measureUnit === "kom")
          {
            e.isDisabled=false;
          }
          else{
            e.isDisabled=true;
          }
        });
       break;

      case "ml":
        this.measureUnits.forEach(e => {
          if(e.measureUnit === "L" || e.measureUnit === "ml")
          {
            e.isDisabled=false;
          }
          else{
            e.isDisabled=true;
          }
        });
      break;
      case "gr":
      this.measureUnits.forEach(e => {
        if(e.measureUnit === "kg" || e.measureUnit === "gr")
        {
          e.isDisabled=false;
        }
        else{
          e.isDisabled=true;
        }
      });
      break;
      
        default:
          break;
      }

    }
    
    open(){
      const modalRef = this.modalService.open(AddIngredientsComponent,
        {
          scrollable: true
        });
 
    modalRef.result.then((result) => {
      this.ingredients.push(result);
    }, (reason) => {
    });
    }



}
