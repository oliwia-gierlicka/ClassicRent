import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar-employee',
  templateUrl: './navbar-employee.component.html',
  styleUrls: ['./navbar-employee.component.scss']
})
export class NavbarEmployeeComponent {

  constructor(private router: Router) { }

  homepage() {
    this.router.navigateByUrl('/');
  }

  logout() {
    sessionStorage.removeItem('token')
    this.homepage();
  }

}
