import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-form-territories',
  templateUrl: './form-territories.component.html',
  styleUrls: ['./form-territories.component.scss']
})
export class FormTerritoriesComponent implements OnInit {

  form: FormGroup;

  get idTerritoryCtrl(): AbstractControl {
    return this.form.get('idTerritory');
  }

  get territoryCtrl(): AbstractControl {
    return this.form.get('territoryDescription');
  }

  get idRegionCtrl(): AbstractControl {
    return this.form.get('idRegion');
  }

  constructor(private readonly fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      idTerritory: ['', Validators.required],
      territoryDescription: ['', Validators.required],
      idRegion: ['', Validators.required]
    });
    
  }
  onSubmit(): void {
    console.log(this.form.value);
  }
  onClickLimpiar(): void {  
    if (this.territoryCtrl){
      this.territoryCtrl.setValue('');     
    }
    if (this.idTerritoryCtrl){
      this.idTerritoryCtrl.setValue('');     
    }
    if (this.idRegionCtrl){
      this.idRegionCtrl.setValue('');     
    }
  }
}
