import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { first } from 'rxjs/operators';
import { IngredientsService } from 'src/app/core/services/ingredients.service';

@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.css']
})
export class IngredientsComponent implements OnInit {
  skip: number=0;
  request:any[]=[];
  ingredients:any=[];
  categoryId: any;
  isLodaMore:boolean=true;
  filterValue:string="";
  tempIngredients:any=[];
  nameofCategory:string;

  constructor(private ingredientsService: IngredientsService, private route: ActivatedRoute) { }

  ngOnInit() {

  }
}
