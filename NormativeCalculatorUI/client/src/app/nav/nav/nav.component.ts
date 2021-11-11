import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  cookieValue:any;
  constructor(private cookieService: CookieService) { }

  ngOnInit(){
    this.cookieValue = this.cookieService.get('auth_cookie');
  }

  logout(){
     this.cookieService.delete(this.cookieValue);
  }

}
