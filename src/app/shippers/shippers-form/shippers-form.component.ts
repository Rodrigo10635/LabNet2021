import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';



@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.scss']
})
export class ShippersFormComponent implements OnInit {

  form: FormGroup;

  
  get CompanyCtrl(): AbstractControl {
    return this.form.get('Company');
  }

  onSubmit(): void {
    console.log(this.form.value);
    console.log(this.form.valid);
  }

 

  constructor(private readonly fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      ShipperID: [],
      CompanyName: ['', Validators.required],
      Phone: []
      
    });
  }

  

  onClickLimpiar(): void {
    
    if (this.CompanyCtrl) {
      this.CompanyCtrl.setValue('');
    }
    
    
  }

  

}
