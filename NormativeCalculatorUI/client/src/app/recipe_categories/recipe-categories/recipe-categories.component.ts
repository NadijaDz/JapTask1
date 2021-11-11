import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';
import { RecipeCategoriesService } from 'src/app/services/recipe-categories.service';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipe-categories.component.html',
  styleUrls: ['./recipe-categories.component.css']
})
export class RecipeCategoriesComponent implements OnInit {
  recipeCategories:any=[];
  take: number=10;

  constructor(private recipeCategoriesService: RecipeCategoriesService) {
    
   }

  ngOnInit() {
     this.getRecipeCategories();
  }

  
  getRecipeCategories() {

    this.recipeCategoriesService
      .get(this.take)
      .pipe(first())
      .subscribe(
        (data) => {
          this.recipeCategories=data;
        },
       
      );
  }


}
