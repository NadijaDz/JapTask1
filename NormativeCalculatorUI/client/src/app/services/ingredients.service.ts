import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class IngredientsService {
  endpoint: string= "Ingredients";

  constructor(private http: HttpClient) {}

  get() {
    return this.http.get<any[]>(`${environment.apiUrl}` + this.endpoint, {
         withCredentials: true
    } );
  }
  save(order: any) {
    return this.http.post(`${environment.apiUrl}${this.endpoint}`, order,{
      withCredentials: true
    });
  }
}
