import { Component } from '@angular/core';
import { Car } from 'src/app/models/car.model';
import { Reservation } from 'src/app/models/reservation.model';
import { CarService } from 'src/app/services/car.service';
import { EmployeeService } from 'src/app/services/employee.service';
import { ReservationService } from 'src/app/services/reservation.service';

@Component({
  selector: 'app-home-employee',
  templateUrl: './home-employee.component.html',
  styleUrls: ['./home-employee.component.scss']
})
export class HomeEmployeeComponent {

  reservations: Reservation[] = [];
  cars: Car[] = [];

  statusMap: {[key: string]: string} = {
    '0': 'Created',
    '1': 'In progress',
    '2': 'Accepted',
    '3': 'Refused'
  }

  constructor(private employeeService: EmployeeService,
    private carService: CarService) {}

  ngOnInit() {
    this.employeeService.getReservations().subscribe(x => {
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

  decision(id: number, status: number) {
    this.employeeService.postDecision(id, status).subscribe(() => {
      this.ngOnInit();
    })
  }

}
