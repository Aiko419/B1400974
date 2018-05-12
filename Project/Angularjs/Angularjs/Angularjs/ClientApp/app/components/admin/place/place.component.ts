import { Component } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { PlaceService } from './place.service';
@Component({
    selector: 'app-place',
    templateUrl: './place.component.html',
})
export class PlaceComponent {
    ng_name = "";
    ng_complete = "";
    placeService: PlaceService | undefined;
    constructor(private http: Http) { }
    httpdata: | undefined;
    ngOnInit() {
        this.http.get("http://localhost:53141/api/todo")
            .map(Response => Response.json())
            .subscribe(data => this.displaydata(data))
    }
    displaydata(data: any) { this.httpdata = data }
    
}

