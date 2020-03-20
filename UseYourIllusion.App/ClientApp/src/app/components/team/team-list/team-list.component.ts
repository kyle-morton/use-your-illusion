import { Component, OnInit } from '@angular/core';
import { TeamService } from '../../../services';
import { TeamViewModel } from '../../../view-models';

@Component({
  selector: 'app-team-list',
  templateUrl: './team-list.component.html',
  styleUrls: ['./team-list.component.css']
})
export class TeamListComponent implements OnInit {

  public teams = [];

  constructor(private service: TeamService) { }

  ngOnInit() {
    this.service.get<[TeamViewModel]>()
      .toPromise()
      .then(result => {
        this.teams = result;
      })
      .catch(err => {
        console.error(err);
      })
  }

}
