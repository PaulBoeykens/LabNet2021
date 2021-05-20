import { Component} from '@angular/core';
import { Territories } from '../models/territories/territories';
import { TerritoriesService} from '../services/territories.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent{

 /* public territoriesList : any = []
  public territories: Territories; 
  public territoriesList:Territories []; */

  public territoriesList:Array<any> = [];

  constructor( private territoriesService:TerritoriesService) {
    this.territoriesService.getTerritories().subscribe((response: any) =>{
   //  this.territoriesList = response;
     console.log(response);
    })
  }
   /*ngOnInit(): void {
    this.territoriesService.getTerritories()
    .subscribe(resp => {this.territoriesList = resp})  
  }*/

  Update(territories:Territories){
    this.territoriesService.sendTerritories(territories);
  }

  Delete(IdTerritory:any){
    this.territoriesService.deleteId(IdTerritory).subscribe()
  }
}
