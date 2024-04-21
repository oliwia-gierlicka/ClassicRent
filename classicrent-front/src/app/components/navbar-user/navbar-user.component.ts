import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar-user',
  templateUrl: './navbar-user.component.html',
  styleUrls: ['./navbar-user.component.scss']
})
export class NavbarUserComponent {

  constructor(private router: Router) { }

  homepage() {
    this.router.navigateByUrl('/');
  }

  logout() {
    sessionStorage.removeItem('token')
    this.homepage();
  }

}
