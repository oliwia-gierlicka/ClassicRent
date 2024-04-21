import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Car } from 'src/app/models/car.model';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-home-user',
  templateUrl: './home-user.component.html',
  styleUrls: ['./home-user.component.scss']
})
export class HomeUserComponent {

  cars: Car[] = [];

  constructor(private carService: CarService,
    private router: Router) {}

  ngOnInit() {
    this.carService.getCars().subscribe(x => {
      this.cars = x;
    });
  }

  makeReservation(car: Car) {
    sessionStorage.setItem('reservation', JSON.stringify({
      id: car.id,
      price: car.pricePerDay,
      name: `${car.brand} ${car.model}`
    }));
    this.router.navigateByUrl('/make-reservation');
  }

}
