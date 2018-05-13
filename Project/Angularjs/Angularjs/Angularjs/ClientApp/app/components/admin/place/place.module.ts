import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpModule } from '@angular/http';
import { PlaceComponent } from './place.component';
import { PlaceService } from './place.service';
import { FormsModule } from '@angular/forms';



@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        BrowserAnimationsModule,
        HttpModule
    ],
    declarations: [
        PlaceComponent
    ]
})
export class PlaceModule { }