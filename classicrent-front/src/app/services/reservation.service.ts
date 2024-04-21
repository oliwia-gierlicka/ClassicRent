import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReservationForm } from '../models/reservation-form.model';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Reservation } from '../models/reservation.model';

@Injectable({
  providedIn: 'root'
})
export class ReservationService {

  constructor(private http: HttpClient) { }

  createReservation(form: ReservationForm): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/reservation`, form);
  }

  getReservations(): Observable<Reservation[]> {
    return this.http.get<Reservation[]>(`${environment.apiUrl}/reservation`);
  }
}
