import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from './data.service';

@Injectable({
  providedIn: 'root'
})
export class TeamService extends DataService {

  constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    super(
      httpClient,
      baseUrl,
      'Team');
  }

}
