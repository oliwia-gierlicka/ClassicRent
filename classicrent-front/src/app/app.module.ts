import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './components/about/about.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { ReviewsComponent } from './components/reviews/reviews.component';
import { ContactComponent } from './components/contact/contact.component';
import { HomeComponent } from './pages/home/home.component';
import { WelcomeSectionComponent } from './components/welcome-section/welcome-section.component';
import { OffersSectionComponent } from './components/offers-section/offers-section.component';
import { OurCarsSectionComponent } from './components/our-cars-section/our-cars-section.component';
import { ContactSectionComponent } from './components/contact-section/contact-section.component';
import { ButtonComponent } from './components/button/button.component';
import { SignInComponent } from './pages/sign-in/sign-in.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { HomeUserComponent } from './pages/home-user/home-user.component';
import { BtnComponent } from './components/btn/btn.component';
import { ReservationComponent } from './pages/reservation/reservation.component';
import { JwtInterceptor } from './interceptor/jwt.interceptor';
import { MyReservationsComponent } from './pages/my-reservations/my-reservations.component';
import { NavbarUserComponent } from './components/navbar-user/navbar-user.component';
import { HomeEmployeeComponent } from './pages/home-employee/home-employee.component';
import { NavbarEmployeeComponent } from './components/navbar-employee/navbar-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    NavbarComponent,
    ReviewsComponent,
    ContactComponent,
    HomeComponent,
    WelcomeSectionComponent,
    OffersSectionComponent,
    OurCarsSectionComponent,
    ContactSectionComponent,
    ButtonComponent,
    SignInComponent,
    HomeUserComponent,
    BtnComponent,
    ReservationComponent,
    MyReservationsComponent,
    NavbarUserComponent,
    HomeEmployeeComponent,
    NavbarEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
