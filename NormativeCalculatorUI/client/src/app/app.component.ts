import { Component } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';
import { AuthenticationService } from './core/services/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  cookieValue:any;
  isUserLoggedIn: boolean = false;
  constructor(private authenticationservice: AuthenticationService,private cookieService: CookieService) { }

ngOnInit() {
  this.cookieValue = this.cookieService.get('auth_cookie');
  if(this.cookieValue != null && this.cookieValue != undefined && this.cookieValue!= ''){
    this.isUserLoggedIn=true;
  }
  else{
    this.isUserLoggedIn=false;
  }
}



}
