import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './core/authGuard/auth.guard';
import { IngredientsComponent } from './features/ingredients/ingredients.component';
import { LoginComponent } from './features/login/login/login.component';
import { RecipeCategoriesComponent } from './features/recipeCategories/recipeCategories.component';
import { AddRecipeComponent } from './features/recipes/addRecipe/add-recipe/add-recipe.component';
import { RecipesComponent } from './features/recipes/recipes.component';

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
