import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { RecipeCategoriesService } from 'src/app/core/services/recipe-categories.service';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipeCategories.component.html',
  styleUrls: ['./recipeCategories.component.css'],
})
export class RecipeCategoriesComponent implements OnInit {
  recipeCategories: any = [];
  recipes: any = [];
  request: any[] = [];
  skip: number = 0;
  isLodaMore: boolean = true;

  constructor(
    private recipeCategoriesService: RecipeCategoriesService,
    private router: Router
  ) {}

  ngOnInit() {
    this.getRecipeCategories();
  }

  getRecipeCategories() {
    this.recipeCategoriesService
      .get(this.skip)
      .pipe(first())
      .subscribe((response: any) => {
        response.data.forEach((val) =>
          this.recipeCategories.push(Object.assign({}, val))
        );

        if (this.recipeCategories.length == response.totalCount) {
          this.isLodaMore = false;
        }
      });
  }

  loadMore() {
    this.skip = this.recipeCategories.length;
    this.getRecipeCategories();
  }
}
