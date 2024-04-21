import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginForm } from 'src/app/models/login-form.model';
import { RegisterForm } from 'src/app/models/register-form.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent {
  option = 0

  signInForm = new FormGroup({
    login: new FormControl(''),
    password: new FormControl('')
  })

  signUpFrom = new FormGroup({
    name: new FormControl(''),
    surname: new FormControl(''),
    phoneNumber: new FormControl(''),
    mail: new FormControl(''),
    login: new FormControl(''),
    password: new FormControl('')
  })

  constructor(
    private userservice: UserService,
    private router: Router
  ) { }

  ngOnInit() {
    if (this.userservice.isLogged()) {
      this.router.navigateByUrl('/home-user');
    }
  }

  change(newoption: number) {
    this.option = newoption
  }

  signIn() {
    this.userservice.login(this.signInForm.value as LoginForm).subscribe(x => {
      sessionStorage.setItem('token', x.token);
      if (x.isEmployee) {
        this.router.navigateByUrl('/home-employee');
      } else {
        this.router.navigateByUrl('/home-user');
      }
    })
  }

  signUp() {
    this.userservice.createUser(this.signUpFrom.value as RegisterForm).subscribe(x => {
      this.change(0);
    });
  }
}
