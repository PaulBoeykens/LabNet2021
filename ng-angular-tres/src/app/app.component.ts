import { Component, OnInit, Output } from '@angular/core';
import * as EventEmitter from 'events';
import { Territories } from './models/territories/territories';
import { TerritoriesService} from './services/territories.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{

  public territoriesList : any = []

  public territories: Territories;

  constructor( private territoriesService:TerritoriesService) {}
  ngOnInit(): void {
    this.territoriesService.getTerritories()
    .subscribe(resp => {this.territoriesList = resp})
  }

  Update(territories:Territories){
    this.territoriesService.sendTerritories(territories);
  }

  Delete(IdTerritory:any){
    this.territoriesService.deleteId(IdTerritory).subscribe()
  }
}
