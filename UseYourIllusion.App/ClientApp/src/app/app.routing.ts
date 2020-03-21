import { HomeComponent, TeamListComponent, TeamDetailsComponent } from "./components";

export const routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'teams', children: [
        { path: '', component: TeamListComponent },
        { path: ':id', component: TeamDetailsComponent }
      ]
    },
  ]