import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { first } from 'rxjs/operators';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  cookieValue:any;
  isUserLoggedIn: boolean = false;

  constructor(private cookieService: CookieService, private loginService: LoginService,private router: Router) { }

  ngOnInit(){
    this.cookieValue = this.cookieService.get('auth_cookie');
    if(this.cookieValue != null && this.cookieValue != undefined && this.cookieValue!= ''){
      this.isUserLoggedIn=true;
    }
    else{
      this.isUserLoggedIn=false;
    }
  }


  logout(){
    this.loginService.signout().pipe(first())
    .subscribe(
      () => {
        this.router.navigate(["/login"]);
        this.isUserLoggedIn=false;
      },
     
    );;
  }

}
