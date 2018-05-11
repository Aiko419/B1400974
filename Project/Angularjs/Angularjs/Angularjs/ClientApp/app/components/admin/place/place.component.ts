import { Component } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Component({
    selector: 'app-place',
    templateUrl: './place.component.html',
})
export class PlaceComponent {
    constructor(private http: Http) { }
    httpdata: | undefined;
    ngOnInit() {
        this.http.get("http://localhost:53141/api/todo")
            .map(Response => Response.json())
            .subscribe(data => this.displaydata(data))
    }
    displaydata(data: any) { this.httpdata = data }
    
}

