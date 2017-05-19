function OnCollisionEnter (info : Collider) {
	Destroy(gameObject);
	ScoreCount.gscore += 1;
}