package nimbledroidmvvm;


public class NIActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NimbleDroidMvvm.NIActivity, NimbleDroidMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NIActivity.class, __md_methods);
	}


	public NIActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NIActivity.class)
			mono.android.TypeManager.Activate ("NimbleDroidMvvm.NIActivity, NimbleDroidMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
