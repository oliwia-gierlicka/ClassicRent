import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { SignInComponent } from './pages/sign-in/sign-in.component';
import { HomeUserComponent } from './pages/home-user/home-user.component';
import { ReservationComponent } from './pages/reservation/reservation.component';
import { MyReservationsComponent } from './pages/my-reservations/my-reservations.component';
import { HomeEmployeeComponent } from './pages/home-employee/home-employee.component';

const routes: Routes = [
  {
    path: 'sign-in',
    component: SignInComponent
  },
  {
    path: 'home-user',
    component: HomeUserComponent
  },
  {
    path: 'home-employee',
    component: HomeEmployeeComponent
  },
  {
    path: 'make-reservation',
    component: ReservationComponent
  },
  {
    path: 'my-reservations',
    component: MyReservationsComponent
  },
  {
    path: '',
    component: HomeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
