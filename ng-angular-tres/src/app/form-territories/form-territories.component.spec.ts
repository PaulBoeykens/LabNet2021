import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormTerritoriesComponent } from './form-territories.component';

describe('FormTerritoriesComponent', () => {
  let component: FormTerritoriesComponent;
  let fixture: ComponentFixture<FormTerritoriesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormTerritoriesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormTerritoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
