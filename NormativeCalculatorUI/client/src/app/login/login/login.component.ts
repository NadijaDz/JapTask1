import { DOCUMENT } from '@angular/common';
import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {


  constructor(private authenticationservice: AuthenticationService,@Inject(DOCUMENT) private document: Document,
              private router: Router) { }

  ngOnInit(): void {
  }

  googleLogIn() {
    let provider = 'provider=Google';
    let returnUrl = 'returnUrl=' +  'http://localhost:4200/recipes';

    this.document.location.href ='https://localhost:5001/api/Login/signin-google' + '?' + provider + '&' + returnUrl;
  }


}
