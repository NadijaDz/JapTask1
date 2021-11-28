import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbModal, NgbModalOptions } from '@ng-bootstrap/ng-bootstrap';
import { first } from 'rxjs/operators';
import { Recipe } from 'src/app/core/models/recipe.model';
import { RecipesService } from 'src/app/core/services/recipes.service';
import { RecipeDetailComponent } from './recipe-details/recipe-detail/recipe-detail.component';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css'],
})
export class RecipesComponent implements OnInit {
  skip: number = 0;
  request: any[] = [];
  recipes: Recipe[] = [];
  categoryId: any;
  isLodaMore: boolean = true;
  filterValue: string = '';
  tempRecipes: any = [];
  nameofCategory: string;
  ingredients: any = [];

  constructor(
    private recipesService: RecipesService,
    private router: Router,
    private route: ActivatedRoute,
    private modalService: NgbModal
  ) {}

  ngOnInit() {
    this.categoryId = this.route.snapshot.paramMap.get('id');
    this.nameofCategory = this.route.snapshot.paramMap.get('name');
    this.getRecipes();
  }

  getRecipes() {
    this.request['categoryId'] = this.categoryId;
    this.request['skip'] = this.skip;
    this.request['searchQuery'] = this.filterValue;
    this.recipesService
      .get(this.request)
      .pipe(first())
      .subscribe((response: any) => {
        if (this.filterValue == '' || this.filterValue == null) {
          response.data.forEach((val) =>
            this.recipes.push(Object.assign({}, val))
          );
          this.tempRecipes = response.data;
        } else {
          this.recipes = response.data;
        }

        if (this.recipes.length == response.totalCount) {
          this.isLodaMore = false;
        }
      });
  }

  loadMore() {
    this.skip = this.recipes.length;
    this.getRecipes();
  }

  searchByFiltrer(filterValue) {
    if (filterValue.length >= 2) {
      this.filterValue = filterValue;
      this.getRecipes();
    }
    this.recipes = this.tempRecipes;
  }

  addNewRecipe() {
    this.router.navigate(['./add-recipe'], {
      relativeTo: this.route,
      skipLocationChange: false,
    });
  }

  getRecipeDetails(id) {
    this.recipesService
      .getById(id)
      .pipe(first())
      .subscribe((response: any) => {
        console.log(response)
        const modalRef = this.modalService.open(RecipeDetailComponent, {
          scrollable: true,
          size: 'lg',
        });
        modalRef.componentInstance.fromParent = response;
        modalRef.result.then(
          (result) => {},
          (reason) => {}
        );
      });
  }
}
