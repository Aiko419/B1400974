import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { Observable } from 'rxjs/Observable';

@Injectable()

export class PlaceService {
    handleError(arg0: any): any {
        throw new Error("Method not implemented.");
    }
    url = "";
    urlEdit = "";
    constructor(private http: Http) {
        
    }
    addarray(value: any) {

        this.url = 'http://localhost:53141/api/todo';
        const headers = new Headers({ "Content-Type": "application/json" });
        const body = JSON.stringify(value);
        return this.http.post(this.url, body, { headers })
            .toPromise()
            .then(res => res.json())
    }
    delete(id: number) {
        this.urlEdit = 'http://localhost:53141/api/todo';
        const url = `${this.urlEdit}/${id}`;
        const httpOptions = {
            headers: new Headers({
                'Content-Type': 'application/json',
            })
        };
        // chưa kiểm tra id đc
        if (id == null) {
            console.error;
        }
        else {
            this.http.delete(url, httpOptions)
                .toPromise()
                .then(() => null)
                .catch(err => console.log(err));
        }       
    }

    getItem(id: number) {
        this.urlEdit = 'http://localhost:53141/api/todo';
        const url = `${this.urlEdit}/${id}`;
        return this.http.get(url)
            .toPromise()
            .then(response => response.json())
            .then(res => console.log(res))
            .catch(this.handleError);
    }

}
