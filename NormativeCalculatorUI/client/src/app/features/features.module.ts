import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login/login.component';
import { AddIngredientsComponent } from './ingredients/add-ingredients/add-ingredients.component';
import { IngredientsComponent } from './ingredients/ingredients.component';
import { RecipeCategoriesComponent } from './recipeCategories/recipeCategories.component';
import { AddRecipeComponent } from './recipes/addRecipe/add-recipe/add-recipe.component';
import { RecipeDetailComponent } from './recipes/recipe-details/recipe-detail/recipe-detail.component';
import { RecipesComponent } from './recipes/recipes.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from '../app-routing.module';

@NgModule({
  declarations: [
    LoginComponent,
    RecipesComponent,
    IngredientsComponent,
    RecipeCategoriesComponent,
    AddRecipeComponent,
    AddIngredientsComponent,
    RecipeDetailComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    AppRoutingModule,
    ReactiveFormsModule,

  ]
})
export class FeaturesModule { }
