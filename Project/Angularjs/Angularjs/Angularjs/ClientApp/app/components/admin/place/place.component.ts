import { Component } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { PlaceService } from './place.service';
import { Location } from '@angular/common';
import { ActivatedRoute, ParamMap } from '@angular/router';
@Component({
    selector: 'app-place',
    templateUrl: './place.component.html',
    providers: [PlaceService]
})
export class PlaceComponent {
    httpdata: | undefined;
    httpdataedit: | undefined;
    isShow = false;
    isShowEdit = false;
    constructor(private http: Http, private placeService: PlaceService, private location: Location, private route: ActivatedRoute,) { }

    ngOnInit() {
        this.http.get("http://localhost:53141/api/todo")
            .map(Response => Response.json())
            .subscribe(data => this.displaydata(data))
    }
    displaydata(data: any) { this.httpdata = data }

    onSubmit(formadd: { value: any; }) {
        this.placeService.addarray(formadd.value)
            .then(result => console.log(result))
            .catch(err => console.log(err));
        this.isShow = false;
    }

    delete(id: number) {      
        this.placeService.delete(id);
    }

    getItem(id: number) {
        this.isShowEdit = true;
        this.placeService.getItem(id).then(data => this.displaydata1(data));
    }
    displaydata1(data: any) { this.httpdataedit = data }
}
