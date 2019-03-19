import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { StarRatingModule } from 'angular-star-rating';

import { AppComponent } from './app.component';
import { DoctorService } from './_services/doctor.service';
import { DoctorListComponent } from './doctor-list/doctor-list.component';
import { appRoutes } from './routes';
import { DoctorListResolver } from './_resolvers/doctor-list-resolver';
import { DoctorDetailComponent } from './doctor-detail/doctor-detail.component';
import { DoctorResolver } from './_resolvers/doctor-resolver';

@NgModule({
  declarations: [AppComponent, DoctorListComponent, DoctorDetailComponent],
  imports: [BrowserModule, HttpClientModule, RouterModule.forRoot(appRoutes), StarRatingModule.forRoot()],
  providers: [DoctorService, DoctorListResolver, DoctorResolver],
  bootstrap: [AppComponent],
})
export class AppModule {}
