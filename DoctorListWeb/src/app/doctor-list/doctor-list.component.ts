import { Component, OnInit } from '@angular/core';
import { Doctor } from '../models/doctor';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.css'],
})
export class DoctorListComponent implements OnInit {
  doctors: Doctor[];

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.doctors = data['doctors'];
    });
  }
}
