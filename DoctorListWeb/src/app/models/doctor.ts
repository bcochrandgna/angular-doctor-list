import { DoctorSpecialty } from './doctorSpecialty';
import { DoctorLanguage } from './doctorLanguage';
import { PatientRating } from './patientRating';

export interface Doctor {
  id: number;
  name: string;
  gender: string;
  specialties?: string;
  averageRating?: number;
  medicalSchool?: string;
  doctorSpecialties?: DoctorSpecialty[];
  doctorLanguages?: DoctorLanguage[];
  patientRatings?: PatientRating[];
}
