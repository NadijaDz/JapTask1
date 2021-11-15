import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './authGuard/auth.guard';
import { HomeComponent } from './home/home/home.component';
import { IngredientsComponent } from './ingredients/ingredients/ingredients.component';
import { LoginComponent } from './login/login/login.component';
import { AddRecipeComponent } from './recipes/addRecipe/add-recipe/add-recipe.component';
import { RecipesComponent } from './recipes/recipes/recipes.component';
import { RecipeCategoriesComponent } from './recipe_categories/recipe-categories/recipe-categories.component';

const routes: Routes = [

  {path:'login', component: LoginComponent},
  {
    path: '',
    runGuardsAndResolvers:'always',
    canActivate: [AuthGuard],
    children:[
    {path:'', component: RecipeCategoriesComponent},
    {path:'ingredients', component: IngredientsComponent},
    {path:'recipes/:id/:name', component: RecipesComponent},
    {path:'recipeCategories', component: RecipeCategoriesComponent},
    {path:'recipes/:id/:name/add-recipe', component: AddRecipeComponent}
    ]},
    {path:'**', component: LoginComponent, pathMatch:'full'},

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
