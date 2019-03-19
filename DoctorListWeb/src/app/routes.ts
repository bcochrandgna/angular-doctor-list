import { Routes } from '@angular/router';
import { DoctorListComponent } from './doctor-list/doctor-list.component';
import { DoctorListResolver } from './_resolvers/doctor-list-resolver';
import { DoctorDetailComponent } from './doctor-detail/doctor-detail.component';
import { DoctorResolver } from './_resolvers/doctor-resolver';

export const appRoutes: Routes = [
  {
    path: 'doctors',
    component: DoctorListComponent,
    resolve: {
      doctors: DoctorListResolver,
    },
  },
  {
    path: 'doctors/:id',
    component: DoctorDetailComponent,
    resolve: {
      doctor: DoctorResolver,
    },
  },
  {
    path: '**',
    redirectTo: 'doctors',
    pathMatch: 'full',
  },
];
