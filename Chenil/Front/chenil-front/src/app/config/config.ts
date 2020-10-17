import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class Config {
  backChenilUrl: string;

  constructor(){
    this.backChenilUrl='https://localhost:8080';
  }
}