import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RecipesComponent } from './recipes/recipes/recipes.component';
import { IngredientsComponent } from './ingredients/ingredients/ingredients.component';
import { RecipeCategoriesComponent } from './recipe_categories/recipe-categories/recipe-categories.component';
import { HomeComponent } from './home/home/home.component';
import { CookieService } from 'ngx-cookie-service';
import { AddRecipeComponent } from './recipes/addRecipe/add-recipe/add-recipe.component';
import { AddIngredientsComponent } from './ingredients/add-ingredients/add-ingredients.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { RecipeDetailComponent } from './recipes/recipe-details/recipe-detail/recipe-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavComponent,
    RecipesComponent,
    IngredientsComponent,
    RecipeCategoriesComponent,
    HomeComponent,
    AddRecipeComponent,
    AddIngredientsComponent,
    RecipeDetailComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule,
    ToastrModule.forRoot({
      timeOut: 3000,
      positionClass: "toast-top-right",
      preventDuplicates: true,
      closeButton: true,
    }),


  ],
  providers: [
    CookieService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
