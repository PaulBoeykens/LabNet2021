import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { Territories } from '../models/territories/territories';

@Injectable({
  providedIn: 'root'
})
export class TerritoriesService {
  private territories = new BehaviorSubject<Territories>(new Territories);
  public territories$ = this.territories.asObservable();
  _url = environment.apiURL
  constructor(
    private http:HttpClient
  ) { }

  sendTerritories(territories:Territories){
    this.territories.next(territories)
  }
  getTerritories():Observable<Territories>{
    let header = new HttpHeaders()
    return this.http.get<Territories>(this._url,{
      headers: header
    });
  }
  /*getTerritories(){
    let header = new HttpHeaders().set('Type-content', 'aplication/json');
    return this.http.get(environment.apiURL, {headers: header});
  }*/


  addTerritories(territories:Territories):Observable<Territories>{
    return this.http.post<Territories>(this._url,territories)
  }
  updateTerritories(territories:Territories):Observable<Territories>{
    return this.http.put<Territories>(this._url+"/"+territories.TerritoryID,territories)
  }
  getTerritoriesId(id: string){
    return this.http.get<Territories>(this._url+"/"+id)
  }
  deleteId(id: string){
    return this.http.delete<Territories>(this._url+"/"+id)
  }
}
