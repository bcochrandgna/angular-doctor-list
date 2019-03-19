import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../..//environments/environment';
import { Doctor } from '../models/doctor';

@Injectable({
  providedIn: 'root',
})
export class DoctorService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getDoctors(): Observable<Doctor[]> {
    return this.http.get<Doctor[]>(`${this.baseUrl}doctors`);
  }

  getDoctor(id: number): Observable<Doctor> {
    return this.http.get<Doctor>(`${this.baseUrl}doctors/${id}`);
  }
}
