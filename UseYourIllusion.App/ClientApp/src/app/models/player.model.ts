import { Team, Base } from ".";

export interface Player extends Base {
  JerseyNumber: number;
  Name: number;
  TeamId: number;
  Team: Team;
}
