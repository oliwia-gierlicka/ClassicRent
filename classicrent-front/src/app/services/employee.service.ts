import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Reservation } from '../models/reservation.model';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getReservations(): Observable<Reservation[]> {
    return this.http.get<Reservation[]>(`${environment.apiUrl}/employee/reservations`);
  }

  postDecision(id: number, status: number): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/employee/reservation`, {
      id,
      status
    });
  }
}
