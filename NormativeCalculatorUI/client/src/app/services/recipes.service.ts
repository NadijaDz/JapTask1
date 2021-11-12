import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {
  endpoint: string= "Recipes";

  constructor(private http: HttpClient) {}

  get(request: any) {
    return this.http.get<any[]>(`${environment.apiUrl}` + this.endpoint, {
         params:new HttpParams()
         .set("skip", request.skip)
         .set("categoryId", request.categoryId)
         .set("searchQuery", request.searchQuery),
         withCredentials: true
    } );
  }
}
