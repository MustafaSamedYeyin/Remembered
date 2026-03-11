import { Routes } from '@angular/router';
import { Box } from './box/box';
import { Card } from 'primeng/card';
import { Deck } from './deck/deck';

export default [
    { path: 'box', component: Box },
    { path: 'deck', component: Deck },
    { path: 'card', component: Card }
] as Routes;
