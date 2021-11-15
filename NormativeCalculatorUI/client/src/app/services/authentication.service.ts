import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUserSubject: BehaviorSubject<any>;
    public currentUser: Observable<any>;


    constructor(private http: HttpClient) {}

    public loginWithGoogle() {
        return this.http.get<any>(`https://localhost:5001/api/Login/signin-google`,
        {
          params: new HttpParams().set('provider', 'Google'),
          headers: new HttpHeaders()
            .set('Access-Control-Allow-Headers', 'Content-Type')
            .set('Access-Control-Allow-Methods', 'GET')
            .set('Access-Control-Allow-Origin', '*')
        })
        .pipe(map(data => {
          return data;
        }));
      }
}