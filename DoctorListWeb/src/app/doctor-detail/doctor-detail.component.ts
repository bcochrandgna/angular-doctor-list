import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Doctor } from '../models/doctor';

@Component({
  selector: 'app-doctor-detail',
  templateUrl: './doctor-detail.component.html',
  styleUrls: ['./doctor-detail.component.css'],
})
export class DoctorDetailComponent implements OnInit {
  doctor: Doctor;
  isSuperstar = false;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.doctor = data['doctor'];
      this.isSuperstar = this.calculateSuperstar(this.doctor.patientRatings);
    });
  }

  calculateSuperstar(patientRatings) {
    const fiveStartRatings = patientRatings.filter(rating => rating.rating === 5);
    return Math.floor(fiveStartRatings.length) / Math.floor(patientRatings.length) >= 0.85;
  }
}
