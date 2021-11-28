import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class RecipeCategoriesService {
  endpoint: string = 'RecipeCategories';

  constructor(private http: HttpClient) {}

  get(skip: any) {
    return this.http.get<any[]>(`${environment.apiUrl}` + this.endpoint, {
      params: new HttpParams().set('skip', skip),
      withCredentials: true,
    });
  }
}
