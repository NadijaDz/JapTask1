import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { RecipesService } from 'src/app/services/recipes.service';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {
  skip: number=0;
  request:any[]=[];
  recipes:any=[];
  categoryId: any;
  isLodaMore:boolean=true;
  filterValue:string="";
  tempRecipes:any=[];

  constructor(private recipesService: RecipesService,  private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
    this.categoryId =this.route.snapshot.paramMap.get('id');
    this.getRecipes();
  }


  getRecipes(){
    
    this.request["categoryId"]=this.categoryId;
    this.request["skip"]=this.skip;
     this.request["searchQuery"]=this.filterValue;
    this.recipesService.get(this.request).pipe(first()).subscribe(
      (response:any)=>{
        if(this.filterValue == "" || this.filterValue==null){
          response.data.forEach(val => this.recipes.push(Object.assign({}, val))); 
          this.tempRecipes=response.data;
        }
        else{
          this.recipes=response.data;
        }
  
        if(this.recipes.length==response.totalCount){
          this.isLodaMore=false;
        }
      }
    )
 }

 loadMore(){
  this.skip=this.recipes.length;
  this.getRecipes();
}
searchByFiltrer(filterValue){

  if(filterValue.length>=2){

    this.filterValue = filterValue;
    this.getRecipes();
  }



   this.recipes=this.tempRecipes;
 
  
}

}
