import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RegisterForm } from '../models/register-form.model';
import { Observable } from 'rxjs';
import { LoginForm } from '../models/login-form.model';
import { Token } from '../models/token.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  createUser(form: RegisterForm): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/user/register/`, form);
  }

  login(form: LoginForm): Observable<Token> {
    return this.http.post<Token>(`${environment.apiUrl}/user/login/`, form);
  }

  isLogged(): boolean {
    return !!sessionStorage.getItem('token');
  }
}
