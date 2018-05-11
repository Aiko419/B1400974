import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpModule } from '@angular/http';
import { PlaceComponent } from './place.component';


@NgModule({
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpModule
    ],
    declarations: [
        PlaceComponent
    ]
})
export class PlaceModule { }