import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { first } from 'rxjs/operators';
import { IngredientsService } from 'src/app/services/ingredients.service';

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
    // this.categoryId =this.route.snapshot.paramMap.get('id');
    // this.nameofCategory =this.route.snapshot.paramMap.get('name');
    // this.getIngredients();
  }


  // getIngredients(){
    

  //   this.request["skip"]=this.skip;

  //   this.ingredientsService.get(this.request).pipe(first()).subscribe(
  //     (response:any)=>{
  //       if(this.filterValue == "" || this.filterValue==null){
  //         response.data.forEach(val => this.ingredients.push(Object.assign({}, val))); 
  //         this.tempIngredients=response.data;
  //       }
  //       else{
  //         this.ingredients=response.data;
  //       }
  
  //       if(this.ingredients.length==response.totalCount){
  //         this.isLodaMore=false;
  //       }
  //     }
  //   )
  //}

//  loadMore(){
//   this.skip=this.ingredients.length;
//   this.getIngredients();
// }
}
