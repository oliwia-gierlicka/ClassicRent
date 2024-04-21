import { Component } from '@angular/core';
import { Car } from 'src/app/models/car.model';
import { Reservation } from 'src/app/models/reservation.model';
import { CarService } from 'src/app/services/car.service';
import { ReservationService } from 'src/app/services/reservation.service';

@Component({
  selector: 'app-my-reservations',
  templateUrl: './my-reservations.component.html',
  styleUrls: ['./my-reservations.component.scss']
})
export class MyReservationsComponent {

  reservations: Reservation[] = [];
  cars: Car[] = [];

  statusMap: {[key: string]: string} = {
    '0': 'Created',
    '1': 'In progress',
    '2': 'Accepted',
    '3': 'Refused'
  }

  constructor(private reservationService: ReservationService,
    private carService: CarService) {}

  ngOnInit() {
    this.reservationService.getReservations().subscribe(x => {
      this.reservations = x;
    })
    this.carService.getCars().subscribe(x => {
      this.cars = x;
    });
  }

  getCarName(id: number): string {
    const car = this.cars.filter(x => x.id === id);
    return `${car[0].brand} ${car[0].model}`;
  }

}
