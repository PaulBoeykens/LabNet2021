import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {HttpClientModule} from '@angular/common/http';

/*
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import {MatListModule} from '@angular/material/list'; */
import { FormTerritoriesComponent } from './form-territories/form-territories.component';
import { ListComponent } from './list/list.component';


@NgModule({
  declarations: [
    AppComponent,
    FormTerritoriesComponent,
    ListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule

  /* MatCardModule,
    MatButtonModule,
    MatListModule,*/
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
