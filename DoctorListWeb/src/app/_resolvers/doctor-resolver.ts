import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, Router } from '@angular/router';
import { Doctor } from '../models/doctor';
import { DoctorService } from '../_services/doctor.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class DoctorResolver implements Resolve<Doctor> {
  constructor(private doctorService: DoctorService, private router: Router) {}

  resolve(route: ActivatedRouteSnapshot): Observable<Doctor> {
    return this.doctorService.getDoctor(route.params['id']).pipe(
      catchError(error => {
        this.router.navigate(['/doctors']);
        return of(null);
      })
    );
  }
}
