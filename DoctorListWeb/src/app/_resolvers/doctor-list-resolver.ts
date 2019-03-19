import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Doctor } from '../models/doctor';
import { DoctorService } from '../_services/doctor.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class DoctorListResolver implements Resolve<Doctor[]> {
  constructor(private doctorService: DoctorService) {}

  resolve(route: ActivatedRouteSnapshot): Observable<Doctor[]> {
    return this.doctorService.getDoctors().pipe(
      catchError(error => {
        return of(null);
      })
    );
  }
}
