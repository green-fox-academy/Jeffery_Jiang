alter table tblEpisode
	add NumberEnemies int

select * from tblEpisode

begin transaction 
	update tblEpisode set NumberEnemies=(
	select count(*) from tblEpisodeEnemy as ee
	where ee.EpisodeId=e.EpisodeId
	)
	from tblEpisode as e;
	if (@@rowcount >100)
	begin
		print @@rowcount +'changed but rolled back' ;
		rollback;
	end
	else
	begin
		print @@rowcount+'changed'
	end
	commit

		