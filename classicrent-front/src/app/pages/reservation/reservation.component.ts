import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ReservationForm } from 'src/app/models/reservation-form.model';
import { ReservationService } from 'src/app/services/reservation.service';

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.scss']
})
export class ReservationComponent {

  carId: number = -1;
  price: number = -1;
  name: string = '';

  form = new FormGroup({
    carId: new FormControl(this.carId, [Validators.required]),
    from: new FormControl('', [Validators.required]),
    to: new FormControl('', [Validators.required]),
    rentPlace: new FormControl('', [Validators.required]),
    returnPlace: new FormControl('', [Validators.required]),
    isFullAssurance: new FormControl(''),
    pay: new FormControl('0', [Validators.required]),
    price: new FormControl('', [Validators.required])
  })

  constructor(private reservationService: ReservationService,
    private router: Router) {}

  ngOnInit() {
    const reservation = JSON.parse(sessionStorage.getItem('reservation') || '{}');

    this.carId = reservation.id;
    this.price = reservation.price;
    this.name = reservation.name;

    this.form.patchValue({
      carId: this.carId,
      price: this.price + ''
    });

    this.form.controls.isFullAssurance.valueChanges.subscribe(x => {
      if (x) {
        this.price += 500;
        this.form.patchValue({
          price: this.price + ''
        });
      } else {
        this.price -= 500;
        this.form.patchValue({
          price: this.price + ''
        });
      }
    })

  }

  makeReservation() {
    if (this.form.valid) {
      const formValues = this.form.value;

      this.reservationService.createReservation({
        carId: this.carId,
        from: formValues.from ?? '',
        to: formValues.to ?? '',
        rentPlace: formValues.rentPlace ?? '',
        returnPlace: formValues.returnPlace ?? '',
        isFullAssurance: !!formValues.isFullAssurance,
        pay: parseInt(formValues.pay || '') === 0 ? 0 : 1,
        price: parseFloat(formValues.price || '')
      }).subscribe(x => {
        sessionStorage.removeItem('reservation')
        this.router.navigateByUrl('/home-user')
      });
    }
  }
}
