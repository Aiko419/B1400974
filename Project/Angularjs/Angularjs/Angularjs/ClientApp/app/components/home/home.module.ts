import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { AboutComponent } from './about/about.component';
import { TourComponent } from './tour/tour.component';
import { ContentComponent } from './content/content.component';
import { HomeComponent } from './home.component';

const routes: Routes = [
    {
        path: 'home',
        component: HomeComponent,
        children: [
            {
                path: '',
                component: ContentComponent
            },
            {
                path: 'about',
                component: AboutComponent
            },
            {
                path: 'tour',
                component: TourComponent
            }
        ]
    }
];
@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild(routes)
    ],
    declarations: [
        HomeComponent,
        AboutComponent,
        ContentComponent,
        TourComponent
    ]
})
export class HomeModule { }